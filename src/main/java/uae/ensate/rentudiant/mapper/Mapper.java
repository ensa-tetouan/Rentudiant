package uae.ensate.rentudiant.mapper;

import lombok.AllArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import uae.ensate.rentudiant.dto.HouseDto;
import uae.ensate.rentudiant.model.Address;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.service.AddressService;

@AllArgsConstructor
public class Mapper {

    public static House mapToHouse(HouseDto houseDto, Address address) {

        House house = new House(
                address,
                houseDto.roomsC(),
                houseDto.bathroomsC(),
                houseDto.bedroomsC(),
                houseDto.description(),
                houseDto.surface(),
                houseDto.rule()
            );

        return house;
    }
}
