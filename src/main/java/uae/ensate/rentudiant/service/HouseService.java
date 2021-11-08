package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.dto.HouseDto;
import uae.ensate.rentudiant.dto.RuleDto;
import uae.ensate.rentudiant.mapper.Mapper;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.repository.HouseRepository;
import uae.ensate.rentudiant.util.Pair;

import java.util.List;
import java.util.Set;
import java.util.stream.Collectors;

@Service
@AllArgsConstructor
public class HouseService {

    private final HouseRepository houseRepository;
    private final AnnouncementService announcementService;
    private final AddressService addressService;

    public List<House> fetchAll () {
        return houseRepository.findAll();
    }

    public List<House> fetchAllByPriceRange(double max, double min) {
        return houseRepository.findAll().stream()
                .map(house -> new Pair<>
                        (house, announcementService.findByHouse(house)))
                .filter(ann ->
                        ann.getP2().getPrice() <= max
                                && ann.getP2().getPrice() >= min)
                .map(Pair::getP1).toList();
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

    public List<House> fetchAllByRules(Set<RuleDto> rules) {
        return houseRepository
                .findByRules(rules.stream()
                        .map(Mapper::mapToRule)
                        .collect(Collectors.toSet()));
    }

    public void update(Long id, HouseDto houseDto) {
        houseRepository.update(
                id,
                Mapper.mapToHouse(
                        houseDto,
                        addressService
                                .findById(houseDto.addressId())));
    }
}
