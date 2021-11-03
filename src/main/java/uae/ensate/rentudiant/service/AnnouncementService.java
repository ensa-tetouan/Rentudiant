package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.model.Announcement;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.repository.AnnouncementRepository;

import java.util.List;

@Service
@AllArgsConstructor
public class AnnouncementService {

    private final AnnouncementRepository announcementRepository;

    public Announcement findByHouse(House house) {
        return announcementRepository.findByHouse(house)
                .orElseThrow(() -> new IllegalArgumentException("House not found"));
    }

    public Announcement add(Announcement announcement) {
        return announcementRepository.save(announcement);
    }

    public List<Announcement> findAll() {
        return announcementRepository.findAll();
    }

    public void delete(Long id) {
        announcementRepository.deleteById(id);
    }
}
