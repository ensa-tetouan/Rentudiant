package uae.ensate.rentudiant.mapper;

import lombok.AllArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import uae.ensate.rentudiant.dto.HouseDto;
import uae.ensate.rentudiant.dto.ReviewDto;
import uae.ensate.rentudiant.model.Address;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.model.Review;
import uae.ensate.rentudiant.service.AddressService;

@AllArgsConstructor
public class Mapper {

    public static House mapToHouse(HouseDto houseDto, Address address) {

        return new House(
                address,
                houseDto.roomsC(),
                houseDto.bathroomsC(),
                houseDto.bedroomsC(),
                houseDto.description(),
                houseDto.surface(),
                houseDto.rule()
            );
    }

    // TODO: Slap the implementation in
    public static Review mapToReview(ReviewDto reviewDto, House byId) {
        return new Review();
    }
}
