package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Picture;

public interface PictureRepository extends JpaRepository<Picture, Long> {
}