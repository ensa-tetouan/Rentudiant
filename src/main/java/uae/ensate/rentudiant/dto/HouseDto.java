package uae.ensate.rentudiant.dto;

import uae.ensate.rentudiant.model.Rule;

import java.util.Set;

public record HouseDto(long addressId, int roomsC,
                       int bathroomsC, int bedroomsC,
                       double surface, String description,
                       Set<Rule> rule) {}
