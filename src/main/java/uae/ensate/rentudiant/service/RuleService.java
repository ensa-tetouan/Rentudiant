package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.repository.RuleRepository;

@Service
@AllArgsConstructor
public class RuleService {

    private final RuleRepository ruleRepository;


}
