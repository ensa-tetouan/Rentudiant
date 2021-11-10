package uae.ensate.rentudiant.service;


import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.dto.PictureDto;
import uae.ensate.rentudiant.mapper.Mapper;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.model.Picture;
import uae.ensate.rentudiant.repository.PictureRepository;

import java.util.List;

@AllArgsConstructor
@Service
public class PictureService {

    private final PictureRepository pictureRepository;

    public void delete(Long id) {
        pictureRepository.deleteById(id);
    }

    public Picture save(PictureDto pictureDto) {
        Picture picture = Mapper.mapToPicture(pictureDto);
        return pictureRepository.save(picture);
    }
}
