package uae.ensate.rentudiant.service;

import javassist.NotFoundException;
import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.model.Announcement;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.repository.AnnouncementRepository;

@Service
@AllArgsConstructor
public class AnnouncementService {

    private final AnnouncementRepository announcementRepository;

    public Announcement findByHouse(House house) {
        return announcementRepository.findByHouse(house)
                .orElseThrow(() -> new IllegalArgumentException("House not found"));
    }
}
