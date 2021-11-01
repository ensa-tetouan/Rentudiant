package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Rating;

public interface RatingRepository extends JpaRepository<Rating, Long> {
}