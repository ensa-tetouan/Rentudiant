package uae.ensate.rentudiant.controller;

import lombok.AllArgsConstructor;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import uae.ensate.rentudiant.service.UserService;

@AllArgsConstructor
@RestController
@RequestMapping(path = "api/v1/user")
@CrossOrigin
public class UserController {
    private final UserService userService;

    private static final Logger logger = LoggerFactory.getLogger(UserController.class);

    @GetMapping
    public void getUser() {

    }
}
