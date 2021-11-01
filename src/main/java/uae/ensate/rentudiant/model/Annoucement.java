package uae.ensate.rentudiant.model;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;
import org.hibernate.Hibernate;
import javax.persistence.*;

@Entity
@Getters @Setters @NoArgsConstructor
@Table(name = "annoucements")
public class Annoucement {
    @Id
    @GeneratedValue(strategy = GenerationType.SEQUENCE)
    @Column(name = "id", updatable = false, nullable = false)
    private Long id;
    private Long houseId;
    private double Price;
}
