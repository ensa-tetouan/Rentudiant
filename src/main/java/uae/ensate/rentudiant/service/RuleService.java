package uae.ensate.rentudiant.service;

import lombok.AllArgsConstructor;
import org.springframework.stereotype.Service;
import uae.ensate.rentudiant.dto.RuleDto;
import uae.ensate.rentudiant.mapper.Mapper;
import uae.ensate.rentudiant.model.Rule;
import uae.ensate.rentudiant.repository.RuleRepository;

@Service
@AllArgsConstructor
public class RuleService {

    private final RuleRepository ruleRepository;

    public Rule save(RuleDto ruleDto) {
        return ruleRepository.save(Mapper.mapToRule(ruleDto));
    }
}
