package uae.ensate.rentudiant.model;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import javax.persistence.*;
import java.util.List;
import java.util.Set;

@Getter
@Setter
@NoArgsConstructor
@Entity
@Table(name = "houses")
public class House {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @ManyToOne
    private Address address;

    @Column(nullable = false)
    private String number;

    @Column(nullable = false)
    private int roomsC;

    @Column(nullable = false)
    private int bathroomsC;

    @Column(nullable = false)
    private int bedroomsC;

    private String description;

    @Column(nullable = false)
    private double surface;

    @OneToMany(fetch = FetchType.LAZY, cascade = CascadeType.ALL)
    private Set<Rule> rules;

    public House(Address address, int roomsC,
                 int bathroomsC, int bedroomsC,
                 String description, double surface,
                 Set<Rule> rules) {
        this.address = address;
        this.roomsC = roomsC;
        this.bathroomsC = bathroomsC;
        this.bedroomsC = bedroomsC;
        this.description = description;
        this.surface = surface;
        this.rules = rules;
    }

}
