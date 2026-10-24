# WPR17(8)1 Project Development & Activity Log

---

### Entry 1: Project Initiation & Risk Mitigation
* **Date:** 05 August 2026 (Week 1, Day 3)
* **Phase:** Project Initiation & Baseline Setup
* **Recorded by:** Alexander Kruger 

#### 1. Process & Setup
* **Communication Channels:** Established primary communication lines via WhatsApp and Microsoft Teams to facilitate rapid daily team synchronization.
* **Repository Configuration:** Initialized the centralized Git repository (`WPR181-Portfolio-Project`). Alexander Kruger scaffolded and committed the standard folder directory structure, baseline file configurations, and semantic HTML5 boilerplates directly to the main upstream branch.

#### 2. Identified Challenges & Risks
* **Issue 1 (Personnel Routing):** Tumisho was incorrectly assigned to Group V-8 due to an upstream cohort routing discrepancy.
* **Issue 2 (MIA Roster Member):** Mihlali was flagged as permanently inactive, showing zero system or portal presence since May 2026.
* **Systemic Impact:** The operational capacity of the development team was reduced from five members to an effective three active members, dramatically inflating individual task workloads under the impending Milestone 1 deadline.

#### 3. Actions Taken & Mitigations
* **Administrative Escalation:** Dispatched a formal notification and roster adjustment request email to the lecturer (Mr. Tendai Mkwaira) on 05 August 2026 to resolve the routing error.
* **Contingency Workflow:** Maintained project velocity by transitioning the remaining active members into a consolidated three-person development structure.
* **Integrity & Accountability Tracking:** Standardized the central Git repository's commit history to act as a verifiable, system-generated log of individual project participation, satisfying the rubric's "compelling evidence of collaboration" requirement.

---

### Entry 2: Team Onboarding & Environment Alignment
* **Date:** 07 August 2026 (Week 1, Day 5)
* **Phase:** Team Onboarding, Configuration Management Alignment & Workload Re-allocation
* **Recorded by:** Alexander Kruger 

#### 1. Roster Stabilization & Workload Re-allocation
* **Personnel Re-integration:** Tumisho successfully re-established communication and confirmed active status within Group V-8.
* **Workload Optimization:** With the team stabilized at four active members, tasks were re-allocated to integrate Tumisho as the **css styling and color engineer**, safely reducing individual workload bottlenecks.
* **Branch Configuration:** Initialized and published a isolated feature branch (`Devolpment--Tumisho`) to the upstream repository to safeguard Tumisho’s localized workspace.

#### 2. Technical Onboarding & Git Crash Course
* **Git Training Seminar:** To mitigate merge conflicts and enforce branch protection protocols, Alexander Kruger conducted a comprehensive *Git & Configuration Management Crash Course* for team member Nduna.
* **Standardized Environment Checklist:** The walkthrough successfully aligned local workspaces on the following workflows:
  * Global Git identity parameters (`user.name` and `user.email`) and environmental PATH setups.
  * Native authentication of Visual Studio Code with GitHub.
  * Repository cloning configurations using the visual GitHub Desktop GUI.
  * Local branch isolation protocols (working exclusively on feature branches).
  * Local changes tracking, staging, semantic committing, and upstream pushing.
  * Generating and submitting Pull Requests (PRs) for peer code review.

#### 3. Current Risk Status
* **Status: [MITIGATED]** Roster constraints and development delay risks are fully resolved. The team is technically aligned on version control protocols and executing feature development for Milestone 1 concurrently.

---

### Entry 3: Technical Restructuring & Integrity Controls
* **Date:** 10 August 2026 (Week 2, Day 1)
* **Phase:** Technical Restructuring, Collaborative Review & Compliance Verification
* **Recorded by:** Alexander Kruger 

#### 1. Roster Progression & Baseline Code Commit
* **Technical Progression:** Tumisho successfully delivered his first baseline styling commit on the `Devolpment--Tumisho` branch. 
* **Deliverables:** This pull request integrated base CSS rules for form inputs and table containers. Alexander Kruger reviewed the code to verify visual compatibility and ensure proper styling inheritance from global design tokens.

#### 2. Strategic Use-Case Pivot & Peer Verification
* **Business Use-Case Pivot:** The active team made a collaborative decision to pivot the site's profile from a personal portfolio to a **Small Business Portfolio Website** for a professional Photography & Videography Studio (trading under the trade name **"Cerulean Lens"**).
* **Current Status:** The conceptual design is currently in a "Design Freeze" state. Page blueprints and wireframe content are circulating among all active team members for validation and peer approval.

#### 3. Structural Development, Local Rendering & Compliance Controls
* **Semantic HTML Expansion:** Alexander Kruger refactored and expanded the semantic HTML5 templates across all four core page layouts (`index.html`, `about.html`, `portfolio.html`, `contact.html`) to support the new commercial media structure.
* **Local UI Sandbox Testing:** Conducted browser-rendering and responsive alignment tests using VS Code Live Server to ensure nested contact fields, packages tables, and portfolio grids load consistently before applying layouts.
* **Academic Integrity Safeguard:** During this rapid prototyping phase, temporary helper styles were implemented locally to check border margins and grid boundaries. Once structural alignments were verified, **all testing helper code was completely purged from the repository** to ensure all final stylesheets are written natively by the team in compliance with institutional academic integrity policies.

---

### Entry 4: Technical Onboarding Success & Milestone 1 Lecturer Review
* **Date:** 12 August 2026 – 13 August 2026 (Week 2, Days 3 & 4)
* **Phase:** Milestone 1 Evaluation & Technical Feedback Iteration
* **Recorded by:** Alexander Kruger 

#### 1. Technical Onboarding Accomplished (12 August)
* **Event:** Reamogetse Matsemela successfully joined the Microsoft Teams call at 14:23.
* **Onboarding Execution:** Alexander Kruger conducted a deep-dive configuration workshop lasting 2 hours and 17 minutes. 
* **Deliverables:** Reamogetse’s local environment (Git global variables, VS Code authentication, and GitHub Desktop integration) was fully configured. He successfully completed his first local clone, branch checkout, and local commit.

#### 2. Milestone 1 Lecturer Review & Feedback (13 August)
* **Event:** Group V-8 attended the scheduled Milestone 1 guidance meeting with Mr. Tendai Mkwaira.
* **Attendance:** Alexander Kruger and Tumisho joined. Reamogetse Matsemela, Nduna, and Mihlali were recorded as no-shows. (Mihlali is officially flagged as inactive).
* **Lecturer Feedback & Scope Adjustments:**
  1. **Homepage Hero Section:** Mr. Mkwaira requested the immediate addition of a high-impact, welcoming "Hero" banner on `index.html` to establish the business's identity immediately upon landing.
  2. **Portfolio CSS Grid:** Enhance the static gallery into a highly optimized, responsive CSS Grid layout to demonstrate solid structural layout principles.
* **Operational Actions:** Alexander Kruger scheduled a mandatory internal team synchronization meeting for later today (13 August) to re-allocate these feedback tasks and establish clear communication boundaries.

---

### Entry 5: Core Code Freeze, Feature Extensions & Coordination Check-In
* **Date:** 15 August 2026 (Week 2, Day 6 - Weekend Sprint)
* **Phase:** Experimental Feature Integration & Merge Conflict Mitigation
* **Recorded by:** Alexander Kruger 

#### 1. Roster Update & Peer Alignment
* **Nduna (Forms/Tables):** Formal apology and roster correction recorded. Nduna is fully aligned on his development track, awaiting upcoming Week 3 lectures before beginning form validation .
* **Reamogetse (Layout/Grid):** Flagged as high-risk. No commits have been made at all from his account. 

#### 2. Experimental Feature Development (Alexander)
* **Status:** Alexander Kruger completed all administrative documentation and core semantic HTML structures.
* **New Implementations:** Commenced development on optional project extensions—specifically, custom CSS hover transitions, focus scale transformations, and interactive navigation overlays .
* **Technical Risk (Merge Conflicts):** Since these advanced visual elements require writing custom Flexbox and CSS Grid alignments, they overlap with the assigned layout track . 

#### 3. Communication & Integration Safeguard
* **Action Taken:** Dispatched a formal, polite integration checkpoint message to Reamogetse on WhatsApp at 07:37 . Requested a formal progress update to synchronize stylesheets and prevent codebase regressions .
* **Contingency Status:** Prepared to absorb the baseline media query layouts if no code is committed by 16 August 2026 to protect the critical path for Tuesday's deadline .