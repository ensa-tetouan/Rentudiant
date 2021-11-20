package uae.ensate.rentudiant.config;

import lombok.AllArgsConstructor;
import org.springframework.boot.ApplicationArguments;
import org.springframework.boot.ApplicationRunner;
import org.springframework.stereotype.Component;
import uae.ensate.rentudiant.enums.Gender;
import uae.ensate.rentudiant.enums.Role;
import uae.ensate.rentudiant.model.User;
import uae.ensate.rentudiant.repository.UserRepository;
import uae.ensate.rentudiant.security.PasswordEncoder;

import java.util.List;

@Component
@AllArgsConstructor
public class DataLoader implements ApplicationRunner {

    private UserRepository userRepository;
    private PasswordEncoder passwordEncoder;

    public void run(ApplicationArguments args) {
        List<User> users = List.of(
                new User("admin", "test",
                        "admin@test.com",
                        passwordEncoder.bCryptPasswordEncoder()
                                .encode("admin123"),
                        Gender.Male, Role.ADMIN),
                new User("renter", "test",
                        "renter@test.com",
                        passwordEncoder.bCryptPasswordEncoder()
                                .encode("renter123"),
                        Gender.Male, Role.RENTER),
                new User("client", "test",
                        "client@test.com",
                        passwordEncoder.bCryptPasswordEncoder()
                                .encode("client123"),
                        Gender.Male, Role.CLIENT)
        );
        users.forEach(user -> user.setEnabled(Boolean.TRUE));

        userRepository.saveAll(users);
    }
}