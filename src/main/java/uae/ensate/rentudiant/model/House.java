package uae.ensate.rentudiant.model;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import javax.persistence.*;
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

    @ManyToOne(
            fetch = FetchType.LAZY,
            cascade = CascadeType.PERSIST
    )
    @JoinColumn(
            name = "address_id",
            nullable = false
    )
    private Address address;

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
}
