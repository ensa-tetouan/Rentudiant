package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Annoucement;

public interface AnnoucementRepository extends JpaRepository<Annoucement, Long> {
}