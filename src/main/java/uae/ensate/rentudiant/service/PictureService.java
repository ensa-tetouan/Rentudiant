package uae.ensate.rentudiant.service;


import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.dto.PictureDto;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.model.Picture;
import uae.ensate.rentudiant.repository.PictureRepository;

import java.util.List;

@AllArgsConstructor
@Service
public class PictureService {

    private final PictureRepository pictureRepository;
    private final HouseService houseService;

    public List<Picture> getPictures(Long id) {
        House house = houseService.findById(id);
        return pictureRepository.findByHouse(house);
    }

    public void delete(Long id) {
        pictureRepository.deleteById(id);
    }

    public void save(PictureDto pictureDto) {
        // TODO: Map pictureDto to picture then save

    }
}
