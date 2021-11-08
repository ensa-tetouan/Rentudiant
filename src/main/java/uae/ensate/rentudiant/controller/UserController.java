package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import uae.ensate.rentudiant.service.UserService;

@AllArgsConstructor
@RestController
@RequestMapping(path = "api/v1/user")
public class UserController {
    private final UserService userService;

    // TODO: I don't know what to do here sires
}
