package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.House;

public interface HouseRepository extends JpaRepository<House, Long> {
}
