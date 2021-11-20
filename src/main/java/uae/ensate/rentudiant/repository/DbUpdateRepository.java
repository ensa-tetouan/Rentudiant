package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.DbUpdate;

import java.util.List;

public interface DbUpdateRepository extends JpaRepository<DbUpdate, Long> {
    List<DbUpdate> findAll();
}
