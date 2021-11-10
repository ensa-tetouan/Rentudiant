package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.springframework.data.repository.query.Param;
import org.springframework.web.bind.annotation.*;
import uae.ensate.rentudiant.dto.PictureDto;
import uae.ensate.rentudiant.model.Picture;
import uae.ensate.rentudiant.service.HouseService;
import uae.ensate.rentudiant.service.PictureService;

import java.util.List;

@RestController
@RequestMapping("/api/v1/pictures")
@AllArgsConstructor
@CrossOrigin
public class PictureController {

    private final PictureService pictureService;
    private final HouseService houseService;

    @GetMapping
    private List<Picture> getPicturesForHouse(@RequestParam("house_id") Long house_id) {
       return houseService.getPictures(house_id);
    }

    @PostMapping("add")
    private String addPicture(@RequestBody PictureDto pictureDto) {
        pictureService.save(pictureDto);
        return "";
    }

    @DeleteMapping("delete")
    private void deletePicture(@RequestParam("id") Long id) {
        pictureService.delete(id);
    }
}
