package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Reservation;

public interface ReservationRepository extends JpaRepository<Reservation, Long> {
}