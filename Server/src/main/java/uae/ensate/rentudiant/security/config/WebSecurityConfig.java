package uae.ensate.rentudiant.security.config;

import lombok.AllArgsConstructor;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.authentication.AuthenticationManager;
import org.springframework.security.config.annotation.authentication.builders.AuthenticationManagerBuilder;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.annotation.web.configuration.WebSecurityConfigurerAdapter;
import org.springframework.security.config.http.SessionCreationPolicy;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.web.authentication.UsernamePasswordAuthenticationFilter;
import uae.ensate.rentudiant.security.JwtRequestFilter;
import uae.ensate.rentudiant.service.UserService;

@Configuration
@AllArgsConstructor
@EnableWebSecurity
public class WebSecurityConfig extends WebSecurityConfigurerAdapter {

    private final UserService userService;

    private final JwtRequestFilter jwtRequestFilter;

    @Override
    protected void configure(AuthenticationManagerBuilder auth) throws Exception {
        auth.userDetailsService(userService);
    }

    @Override
    protected void configure(HttpSecurity http) throws Exception {
        http
                .csrf().disable()
                .authorizeRequests()
                .antMatchers("/api/v*/authenticate").permitAll()
                .antMatchers("/api/v*/register/**").permitAll()
                .antMatchers("/api/v*/announcement/**").permitAll()
                .antMatchers("/api/v*/house/**", "/api/v*/address/**").permitAll()
                .anyRequest().authenticated()
                .and().sessionManagement()
                .sessionCreationPolicy(SessionCreationPolicy.STATELESS);
        http.addFilterBefore(jwtRequestFilter, UsernamePasswordAuthenticationFilter.class);
                //.antMatchers("/api/v*/announcements").permitAll()
                //.antMatchers("/api/v*/announcements/**").hasAnyRole("Admin", "Renter")
                //.antMatchers("/api/v*/house/**").hasAnyRole("Admin", "Renter")
                //.antMatchers("/api/v*/**").permitAll()
                //.antMatchers("/api/v*/users/**").hasAuthority("Admin")
                //.anyRequest()
                //.anyRequest()
                //.authenticated().and()
                //.httpBasic();
                //.authenticated().and()
                //.formLogin().loginPage("/login")
                //.failureUrl("/login?error")
                //.usernameParameter("email")
                //.permitAll().and().logout()
                //.logoutUrl("/logout").deleteCookies("remember-me")
                //.logoutSuccessUrl("/").permitAll().and().rememberMe();
    }

    //@Override
    //protected void configure(AuthenticationManagerBuilder auth) throws Exception {
    //    auth.authenticationProvider(daoAuthenticationProvider());
    //}

    //@Bean
    //public DaoAuthenticationProvider daoAuthenticationProvider() {
    //    DaoAuthenticationProvider provider = new DaoAuthenticationProvider();
    //    provider.setPasswordEncoder(bcryptPasswordEncoder);
    //    provider.setUserDetailsService(userService);
    //    return provider;
    //}

    @Bean
    @Override
    public AuthenticationManager authenticationManagerBean() throws Exception {
        return super.authenticationManagerBean();
    }
}
