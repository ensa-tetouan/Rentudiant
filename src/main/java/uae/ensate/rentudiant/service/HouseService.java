package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.model.Announcement;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.repository.HouseRepository;
import uae.ensate.rentudiant.util.Pair;

import java.util.List;
import java.util.stream.Stream;

@Service
@AllArgsConstructor
public class HouseService {

    private final HouseRepository houseRepository;
    private final AnnouncementService announcementService;

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

    public House add(House house) {
        return houseRepository.save(house);
    }

    public void delete(Long id) {
        houseRepository.deleteById(id);
    }
}
