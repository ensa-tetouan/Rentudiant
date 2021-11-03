package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.model.Review;

import java.util.Optional;
import java.util.Set;

public interface ReviewRepository extends JpaRepository<Review, Long> {

    Set<Review> findByHouse(House house);

    void deleteByHouse(House house);


}