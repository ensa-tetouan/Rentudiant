package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Comment;

import java.util.Optional;

public interface CommentRepository extends JpaRepository<Comment, Long> {

    Optional<Comment> findById(Long id);

    void deleteById(Long id);
}