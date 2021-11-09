package uae.ensate.rentudiant.dto;

import uae.ensate.rentudiant.model.User;

import java.time.LocalDateTime;
import java.util.Set;

public record ReservationDto (Long houseId, User Owner,
                              Set<User> users,
                              LocalDateTime startPeriod,
                              LocalDateTime endPeriod,
                              LocalDateTime createdAt) {
}
