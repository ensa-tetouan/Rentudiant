package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.model.Address;
import uae.ensate.rentudiant.repository.AddressRepository;

@AllArgsConstructor
@Service
public class AddressService {

    private final AddressRepository addressRepository;

    public Address findById(Long id) {
        return addressRepository.findById(id)
                .orElseThrow(() -> new IllegalStateException("Address not found"));
    }
}
