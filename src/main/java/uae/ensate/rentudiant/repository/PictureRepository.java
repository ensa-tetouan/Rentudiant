package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.model.Picture;

import java.util.Optional;
import java.util.stream.Stream;

public interface PictureRepository extends JpaRepository<Picture, Long> {

    Stream<Picture> findByHouse(House house);

    void deleteById(Long id);
}