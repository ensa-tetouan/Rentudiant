package uae.ensate.rentudiant.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import uae.ensate.rentudiant.model.Comment;

public interface CommentRepository extends JpaRepository<Comment, Long> {
}