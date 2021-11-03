package uae.ensate.rentudiant.service;


import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.model.Picture;
import uae.ensate.rentudiant.repository.PictureRepository;

import java.util.List;

@AllArgsConstructor
@Service
public class PictureService {

    private final PictureRepository pictureRepository;

    public List<Picture> getPictures(House house) {
       return pictureRepository.findByHouse(house);
    }

    public void delete(Long id) {
        pictureRepository.deleteById(id);
    }
}
