package uae.ensate.rentudiant.mapper;

import lombok.AllArgsConstructor;
import uae.ensate.rentudiant.dto.*;
import uae.ensate.rentudiant.model.*;

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

    public static Reservation mapToReservation(ReservationDto reservationDto, House house) {
        return new Reservation(
                house,
                reservationDto.owner(),
                reservationDto.users(),
                reservationDto.startPeriod(),
                reservationDto.endPeriod(),
                reservationDto.createdAt()
        );
    }
}
