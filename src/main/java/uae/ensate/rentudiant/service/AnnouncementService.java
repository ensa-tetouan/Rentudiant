package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.dto.AnnouncementDto;
import uae.ensate.rentudiant.mapper.Mapper;
import uae.ensate.rentudiant.model.Announcement;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.repository.AnnouncementRepository;

import java.util.List;

@Service
@AllArgsConstructor
public class AnnouncementService {

    private final AnnouncementRepository announcementRepository;
    private final HouseService houseService;

    public Announcement findByHouse(House house) {
        return announcementRepository.findByHouse(house)
                .orElseThrow(() -> new IllegalArgumentException("House not found"));
    }

    public Announcement add(AnnouncementDto announcementDto) {
        return announcementRepository.save(
                Mapper.mapToAnnouncement(
                        announcementDto,
                        houseService
                                .findById(announcementDto.idHouse())));
    }

    public List<Announcement> findAll() {
        return announcementRepository.findAll();
    }

    public void delete(Long id) {
        announcementRepository.deleteById(id);
    }

    public void update(Long id, AnnouncementDto announcementDto) {
       Announcement announcement = findById(id);

       Announcement modAnnouncement = Mapper.mapToAnnouncement(
               announcementDto,
               houseService.findById(announcementDto.idHouse()));

       announcement.setHouse(modAnnouncement.getHouse());
       announcement.setPrice(modAnnouncement.getPrice());
       announcement.setType(modAnnouncement.getType());
       announcementRepository.save(announcement);
    }

    public Announcement findById(Long id) {
        return announcementRepository.findById(id)
                .orElseThrow(() -> new IllegalStateException(
                        String.format("Announcement by %s not found", id)));
    }
}
