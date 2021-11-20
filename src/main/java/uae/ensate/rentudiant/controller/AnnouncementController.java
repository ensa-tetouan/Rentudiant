package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;
import uae.ensate.rentudiant.dto.AnnouncementDto;
import uae.ensate.rentudiant.dto.RuleDto;
import uae.ensate.rentudiant.model.Announcement;
import uae.ensate.rentudiant.service.AnnouncementService;

import java.util.List;
import java.util.Set;

@AllArgsConstructor
@RestController
@RequestMapping(path = "/api/v1/announcement")
public class AnnouncementController {

    public final AnnouncementService announcementService;

    @PreAuthorize("hasAnyAuthority('ADMIN', 'RENTER')")
    @PostMapping(path = "add")
    public ResponseEntity<Long> addAnnouncement(@RequestBody AnnouncementDto announcementDto) {
        Announcement announcement = announcementService.add(announcementDto);
        return ResponseEntity.ok(announcement.getId());
    }

    @GetMapping
    public ResponseEntity<List<Announcement>> listAnnouncements() {
        return ResponseEntity.ok(announcementService.findAll());
    }

    @PreAuthorize("hasAnyAuthority('ADMIN', 'RENTER')")
    @DeleteMapping("delete")
    public void deleteAnnouncement(@RequestParam("id") Long id) {
        announcementService.delete(id);
    }

    @PreAuthorize("hasAnyAuthority('ADMIN', 'RENTER')")
    @PutMapping("update")
    public void updateAnnouncement(@RequestParam("id") Long id,
                                   @RequestBody AnnouncementDto announcementDto) {
        announcementService.update(id, announcementDto);
    }

    @GetMapping("range")
    public ResponseEntity<List<Announcement>> getInRange(@RequestParam("max") double max,
                                                         @RequestParam("min") double min) {
        return ResponseEntity
                .ok(announcementService.fetchAllByPriceRange(max, min));
    }

    @GetMapping("rules")
    public ResponseEntity<List<Announcement>> getByRules(@RequestBody Set<RuleDto> rules) {
        return ResponseEntity
                .ok(announcementService.fetchAllByRules(rules));
    }
}
