package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.springframework.data.repository.query.Param;
import org.springframework.web.bind.annotation.*;
import uae.ensate.rentudiant.dto.PictureDto;
import uae.ensate.rentudiant.model.Picture;
import uae.ensate.rentudiant.service.PictureService;

import java.util.List;

@RestController("/api/v1/house")
@AllArgsConstructor
public class PictureController {

    private final PictureService pictureService;

    @GetMapping("{id}/pictures")
    private List<Picture> getPicturesForHouse(@PathVariable Long id) {
       return pictureService.getPictures(id);
    }

    @PostMapping("pictures/add")
    private String addPicture(@RequestBody PictureDto pictureDto) {
        pictureService.save(pictureDto);
        return "";
    }
}
