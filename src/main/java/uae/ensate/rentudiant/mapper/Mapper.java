package uae.ensate.rentudiant.mapper;

import lombok.AllArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import uae.ensate.rentudiant.dto.AnnouncementDto;
import uae.ensate.rentudiant.dto.HouseDto;
import uae.ensate.rentudiant.dto.ReviewDto;
import uae.ensate.rentudiant.dto.RuleDto;
import uae.ensate.rentudiant.model.*;
import uae.ensate.rentudiant.service.AddressService;

@AllArgsConstructor
public class Mapper {

    public static House mapToHouse(HouseDto houseDto, Address address) {

        return new House(
                address,
                houseDto.roomsC(),
                houseDto.bathroomsC(),
                houseDto.bedroomsC(),
                houseDto.description(),
                houseDto.surface(),
                houseDto.rule()
            );
    }

    public static Review mapToReview(ReviewDto reviewDto, House house) {
        return new Review(
                house,
                reviewDto.rating()
        );
    }

    public static Rule mapToRule(RuleDto ruleDto) {
        return new Rule(
                ruleDto.ruleBody(),
                ruleDto.penalty()
        );
    }

    public static Announcement mapToAnnouncement(AnnouncementDto announcementDto, House house) {
       return new Announcement(
               house,
               announcementDto.announcementType(),
               announcementDto.price()
       );
    }
}
