package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.dto.ReviewDto;
import uae.ensate.rentudiant.mapper.Mapper;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.model.Review;
import uae.ensate.rentudiant.repository.HouseRepository;
import uae.ensate.rentudiant.repository.ReviewRepository;

import java.util.List;

@AllArgsConstructor
@Service
public class ReviewService {

    private final ReviewRepository reviewRepository;
    private final HouseService houseService;

    public List<Review> fetchReviewsByHouse(Long houseId) {
        House house = houseService.findById(houseId);
        return reviewRepository.findByHouse(house);
    }

    public void save(ReviewDto reviewDto) {
      Review review = Mapper.mapToReview(reviewDto, houseService.findById(reviewDto.idHouse()));
      reviewRepository.save(review);
    }

    public void delete(Long id) {
        reviewRepository.deleteById(id);
    }

    public void update(Long id, ReviewDto reviewDto) {
        Review review = findById(id);
        Review modifiedReview = Mapper
                .mapToReview(reviewDto,
                        houseService.findById(reviewDto.idHouse())
                );

        review.setHouse(modifiedReview.getHouse());
        review.setRating(modifiedReview.getRating());

        reviewRepository.save(review);
    }

    public Review findById(Long id) {
        return reviewRepository.findById(id)
                .orElseThrow(() ->
                        new IllegalStateException(""));
    }
}
