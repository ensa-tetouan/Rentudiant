package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.dto.HouseDto;
import uae.ensate.rentudiant.mapper.Mapper;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.repository.HouseRepository;

import java.util.List;

@Service
@AllArgsConstructor
public class HouseService {

    private final HouseRepository houseRepository;
    private final AddressService addressService;
    private final UserService userService;

    public List<House> fetchAll () {
        return houseRepository.findAll();
    }

    public House add(HouseDto houseDto) {
        House house = Mapper.mapToHouse(
                    houseDto,
                    addressService.findById(houseDto.addressId())
            );
        return houseRepository.save(house);
    }

    public void delete(Long id) {
        houseRepository.deleteById(id);
    }

    public House findById(Long id) {
        return houseRepository.findById(id)
                .orElseThrow(() -> new IllegalStateException("House with id=" + id + "not found"));
    }

    public void update(Long id, HouseDto houseDto) {
        House house = findById(id);
        House modHouse = Mapper.mapToHouse(houseDto, addressService.findById(houseDto.addressId()));

        house.setAddress(modHouse.getAddress());
        house.setBathroomsC(modHouse.getBathroomsC());
        house.setBedroomsC(modHouse.getBedroomsC());
        house.setDescription(modHouse.getDescription());
        house.setNumber(modHouse.getNumber());
        house.setRules(modHouse.getRules());
        house.setSurface(modHouse.getSurface());

        houseRepository.save(house);
    }

    public List<House> findAll() {
        return houseRepository.findAll();
    }
}
