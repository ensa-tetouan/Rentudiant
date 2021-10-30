package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.User;

public interface UserRepository extends JpaRepository<User, Long> {
}

