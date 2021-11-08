package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.dto.RuleDto;
import uae.ensate.rentudiant.model.House;
import uae.ensate.rentudiant.model.Rule;

import java.util.List;
import java.util.Optional;
import java.util.Set;
import java.util.stream.Stream;

public interface HouseRepository extends JpaRepository<House, Long> {

    Optional<House> findById(Long id);

    List<House> findAll();

    void deleteById(Long id);

    List<House> findByRules(Set<Rule> rules);
}
