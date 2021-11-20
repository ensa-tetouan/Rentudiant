package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;
import uae.ensate.rentudiant.dto.ReviewDto;
import uae.ensate.rentudiant.dto.ReviewResponseDto;
import uae.ensate.rentudiant.mapper.Mapper;
import uae.ensate.rentudiant.model.Review;
import uae.ensate.rentudiant.service.ReviewService;

import java.util.List;

@AllArgsConstructor
@RestController
@RequestMapping(path = "api/v1/review")
@CrossOrigin
public class ReviewController {

    private final ReviewService reviewService;

    @GetMapping("house")
    public ResponseEntity<List<ReviewResponseDto>> fetchReviewsByHouse(@RequestParam("house_id") Long id) {
        return ResponseEntity.ok(reviewService
                .fetchReviewsByHouse(id)
                .stream().map(Mapper::mapToReviewResponse)
                .toList());
    }

    @GetMapping
    public ResponseEntity<ReviewResponseDto> findReviewById(@RequestParam("id") Long id) {
        return ResponseEntity.ok(
                Mapper.mapToReviewResponse(reviewService.findById(id)));
    }

    @PostMapping
    public ResponseEntity<Long> addReviewToHouse(@RequestBody ReviewDto reviewDto) {
        Review review = reviewService.save(reviewDto);
        return ResponseEntity.ok(review.getId());
    }

    @DeleteMapping
    public void deleteReview(@RequestParam("id") Long id, @RequestParam("user_id") Long userId) {
        reviewService.delete(id, userId);
    }

    @PutMapping("update")
    public void updateReview(@RequestParam("id") Long id, @RequestParam("user_id") Long userId, @RequestBody ReviewDto reviewDto) {
        reviewService.update(id, reviewDto);
    }
}
