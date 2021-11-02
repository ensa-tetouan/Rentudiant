package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Review;

public interface ReviewRepository extends JpaRepository<Review, Long> {
}