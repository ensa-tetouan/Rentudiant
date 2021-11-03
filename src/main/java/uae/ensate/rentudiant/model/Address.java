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
@Table(name = "addresses")
public class Address {
    @Id
    @Column(name = "id", nullable = false)
    private Long id;

    private String city;

    private String street;

    public Address(String city, String street) {
        this.city = city;
        this.street = street;
    }

}
