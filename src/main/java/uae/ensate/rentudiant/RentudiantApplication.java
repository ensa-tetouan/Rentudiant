package uae.ensate.rentudiant;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.RestController;

@SpringBootApplication
@RestController
public class RentudiantApplication {

    public static void main(String[] args) {
        SpringApplication.run(RentudiantApplication.class, args);
    }
}
