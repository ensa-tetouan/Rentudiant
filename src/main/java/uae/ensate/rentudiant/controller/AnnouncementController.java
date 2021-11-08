package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.web.bind.annotation.*;
import uae.ensate.rentudiant.dto.AnnouncementDto;
import uae.ensate.rentudiant.model.Announcement;
import uae.ensate.rentudiant.service.AnnouncementService;
import uae.ensate.rentudiant.service.HouseService;

import java.util.List;

@AllArgsConstructor
@RestController
@RequestMapping(path = "/api/v1/announcements")
public class AnnouncementController {

    public final AnnouncementService announcementService;

    @PostMapping(path = "add")
    public String addAnnouncement(@RequestBody AnnouncementDto announcementDto) {
        announcementService.add(announcementDto);
        return "";
    }

    @GetMapping
    public List<Announcement> listAnnouncements() {
        return announcementService.findAll();
    }

    @DeleteMapping("delete")
    public void deleteAnnouncement(@RequestParam("id") Long id) {
        announcementService.delete(id);
    }

    @PutMapping("update")
    public void updateAnnouncement(@RequestParam("id") Long id, @RequestBody AnnouncementDto announcementDto) {
        announcementService.update(id, announcementDto);
    }
}
