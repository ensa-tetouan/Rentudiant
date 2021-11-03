package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Reservation;

import java.util.Optional;

public interface ReservationRepository extends JpaRepository<Reservation, Long> {

    Optional<Reservation> findById(Long id);

    void deleteById(Long id);
}