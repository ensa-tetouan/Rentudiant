package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.springframework.data.repository.query.Param;
import org.springframework.security.core.parameters.P;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.service.HouseService;

import java.util.List;

@RestController("/api/v1/house")
@AllArgsConstructor
public class HouseController {

    private HouseService houseService;

    @PostMapping("/add")
    public String addHouse(@RequestParam House house) {
       houseService.add(house);
       return "";
    }

    @GetMapping
    public List<House> getAll() {
        return houseService.fetchAll();
    }

    @GetMapping("range")
    public List<House> getInRange(@RequestParam("max") double max, @RequestParam("min") double min) {
        return houseService.fetchAllByPriceRange(max, min);
    }

    @GetMapping("delete")
    public void delete(@RequestParam("id") Long id) {
        houseService.delete(id);
    }
}
