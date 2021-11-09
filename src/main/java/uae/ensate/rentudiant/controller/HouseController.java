package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.springframework.web.bind.annotation.*;
import uae.ensate.rentudiant.dto.HouseDto;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.service.AnnouncementService;
import uae.ensate.rentudiant.service.HouseService;
import uae.ensate.rentudiant.service.RuleService;

import java.util.List;

@RestController
@RequestMapping("/api/v1/house")
@AllArgsConstructor
public class HouseController {

    private HouseService houseService;
    private AnnouncementService announcementService;
    private RuleService ruleService;

    @PostMapping("add")
    public String addHouse(@RequestParam HouseDto house) {
       houseService.add(house);
       return "";
    }

    @GetMapping
    public List<House> getAll() {
        return houseService.fetchAll();
    }


    @DeleteMapping("delete")
    public void delete(@RequestParam("id") Long id) {
        houseService.delete(id);
    }

    @PutMapping("update")
    public void update(@RequestParam("id") Long id, @RequestBody HouseDto houseDto) {
        houseService.update(id, houseDto);
    }
}
