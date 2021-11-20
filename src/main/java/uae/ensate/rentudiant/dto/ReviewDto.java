package uae.ensate.rentudiant.dto;

public record ReviewDto(Long userId, Long idHouse, String body, double rating) {}