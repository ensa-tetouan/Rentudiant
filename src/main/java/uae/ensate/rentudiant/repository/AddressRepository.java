package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Address;

public interface AddressRepository extends JpaRepository<Address, Long> {
}