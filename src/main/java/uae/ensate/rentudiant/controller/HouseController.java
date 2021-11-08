package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.springframework.data.repository.query.Param;
import org.springframework.security.core.parameters.P;
import org.springframework.web.bind.annotation.*;
import uae.ensate.rentudiant.dto.HouseDto;
import uae.ensate.rentudiant.dto.RuleDto;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.service.HouseService;
import uae.ensate.rentudiant.service.RuleService;

import java.util.List;
import java.util.Set;

@RestController
@RequestMapping("/api/v1/house")
@AllArgsConstructor
public class HouseController {

    private HouseService houseService;
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

    @GetMapping("range")
    public List<House> getInRange(@RequestParam("max") double max, @RequestParam("min") double min) {
        return houseService.fetchAllByPriceRange(max, min);
    }

    @DeleteMapping("delete")
    public void delete(@RequestParam("id") Long id) {
        houseService.delete(id);
    }

    @GetMapping("rules")
    public List<House> getByRules(@RequestBody Set<RuleDto> rules) {
        return houseService.fetchAllByRules(rules);
    }
}
