package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Rule;

public interface RuleRepository extends JpaRepository<Rule, Long> {
}