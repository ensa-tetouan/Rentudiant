package uae.ensate.rentudiant.dto;

import lombok.AllArgsConstructor;
import lombok.EqualsAndHashCode;
import lombok.Getter;
import lombok.ToString;
import uae.ensate.rentudiant.enums.Gender;
import uae.ensate.rentudiant.enums.Role;

@Getter
@AllArgsConstructor
@EqualsAndHashCode
@ToString
public class RegistrationDto {
    private final String firstName;
    private final String lastName;
    private final String username;
    private final String email;
    private final String password;
    private final Gender gender;
    private final Role role;
}
