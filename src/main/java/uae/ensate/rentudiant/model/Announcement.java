package uae.ensate.rentudiant.model;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import uae.ensate.rentudiant.enums.AnnouncementType;

import javax.persistence.*;

@Getter
@Setter
@NoArgsConstructor
@Entity
@Table(name = "annoucements")
public class Announcement {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @OneToOne(
            fetch = FetchType.LAZY,
            orphanRemoval = true
    )
    @JoinColumn(
            name = "house_id",
            nullable = false
    )
    private House house;

    @Enumerated(EnumType.STRING)
    @Column(nullable = false)
    private AnnouncementType type;

    private double Price;
}
