package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.dto.ReviewDto;
import uae.ensate.rentudiant.mapper.Mapper;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.model.Review;
import uae.ensate.rentudiant.model.User;
import uae.ensate.rentudiant.repository.ReviewRepository;

import java.util.List;

@AllArgsConstructor
@Service
public class ReviewService {

    private final ReviewRepository reviewRepository;
    private final HouseService houseService;
    private final UserService userService;
    private final DbUpdateService dbUpdateService;

    public List<Review> fetchReviewsByHouse(Long houseId) {
        House house = houseService.findById(houseId);
        return reviewRepository.findByHouse(house);
    }

    public Review save(ReviewDto reviewDto) {
      Review review = Mapper.mapToReview(
              reviewDto,
              userService.findById(reviewDto.userId()),
              houseService.findById(reviewDto.idHouse()));
      dbUpdateService.dbUpdated();

      return reviewRepository.save(review);
    }

    public void delete(Long id, Long userId) {
        dbUpdateService.dbUpdated();
        User user = userService.findById(id);
        if (findById(id).getUser().equals(user))
            reviewRepository.deleteById(id);

    }

    public void update(Long id, ReviewDto reviewDto) {
        Review review = findById(id);
        User user = userService.findById(reviewDto.userId());

        if (review.getUser()
                .equals(user)) {
            Review modifiedReview = Mapper
                    .mapToReview(reviewDto,
                            user,
                            houseService.findById(reviewDto.idHouse())
                    );

            review.setHouse(modifiedReview.getHouse());
            review.setRating(modifiedReview.getRating());

            dbUpdateService.dbUpdated();
            reviewRepository.save(review);
        }
    }

    public Review findById(Long id) {
        return reviewRepository.findById(id)
                .orElseThrow(() ->
                        new IllegalStateException(""));
    }
}
