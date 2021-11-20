package uae.ensate.rentudiant.model;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.*;
import javax.validation.constraints.DecimalMax;
import javax.validation.constraints.DecimalMin;

@Getter
@Setter
@NoArgsConstructor
@Entity
@Table(name = "reviews")
public class Review {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @ManyToOne(cascade = CascadeType.PERSIST, fetch = FetchType.LAZY)
    @JoinColumn(name = "house_review_id", nullable = false)
    private House house;

    @OneToOne(cascade = CascadeType.PERSIST)
    @JoinColumn(name = "user_review_id", nullable = false)
    private User user;

    private String body;

    @DecimalMin(value = "0.0")
    @DecimalMax(value = "10.0")
    private double rating;

    public Review(House house, User user,
                  String body, double rating) {
        this.house = house;
        this.user = user;
        this.body = body;
        this.rating = rating;
    }

}
