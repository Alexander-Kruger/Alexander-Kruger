# Git Basics — Team Setup Guide

Welcome! This guide walks you through installing Git, connecting it to this repository, and the everyday commands you'll use to pull, commit, and push changes. Read it once, then keep it open as a reference for your first few weeks.

---

## 1. Install Git

**Windows**
1. Download the installer from [git-scm.com](https://git-scm.com/download/win).
2. Run it and keep the default options (it's safe to click "Next" through the whole thing).
3. Open **Git Bash** (installed alongside Git) to confirm it worked — see step 3 below.

**Mac**
1. Open Terminal and type:
   ```
   git --version
   ```
2. If Git isn't installed, macOS will prompt you to install the Xcode Command Line Tools — accept it. Alternatively, install via [Homebrew](https://brew.sh): `brew install git`.

**Linux**
```
sudo apt update
sudo apt install git
```
(Use your distro's package manager if not Debian/Ubuntu-based.)

**VS Code users:** VS Code has Git built in — you don't need a separate app to use it, just the Git installation above. Once installed, VS Code's **Source Control** panel (the icon that looks like a branching line, on the left sidebar) will let you stage, commit, and push through a UI instead of typing commands, if you prefer that. Everything in this guide works either way — the commands below are the terminal equivalent of what those buttons do.

### Confirm it's installed
```
git --version
```
You should see something like `git version 2.44.0`.

---

## 2. One-Time Setup (do this once per computer)

Tell Git who you are — this info gets attached to every commit you make:

```
git config --global user.name "Your Name"
git config --global user.email "your.email@example.com"
```

Use the same email you use for your GitHub (or GitLab/etc.) account so your commits are linked to your profile.

Check it worked:
```
git config --global user.name
git config --global user.email
```

---

## 3. Get the Project Onto Your Computer

You only need to do this **once** per project, on each computer you work from.

1. Go to the repository page on GitHub.
2. Click the green **Code** button and copy the URL (use HTTPS unless your team uses SSH keys).
3. In a terminal, navigate to the folder where you want the project to live, then run:
   ```
   git clone https://github.com/your-team/your-repo.git
   ```
4. Move into the new folder:
   ```
   cd your-repo
   ```

That's it — you now have a full copy of the project, including its history.

---

## 4. The Daily Workflow

This is the loop you'll repeat constantly. **Always pull before you start working, and again before you push.**

### Step 1 — Pull the latest changes
Before you start editing anything, make sure you have everyone else's latest work:
```
git pull
```
This prevents a lot of avoidable conflicts.

### Step 2 — Check what you've changed
```
git status
```
Shows which files you've modified, added, or deleted.

### Step 3 — Stage your changes
Staging means "select what I want to include in this commit."
```
git add filename.html        # stage one specific file
git add .                    # stage everything you changed
```

### Step 4 — Commit
A commit is a saved snapshot with a message describing what changed:
```
git commit -m "Add navigation bar to homepage"
```
Write messages that describe *what* changed and *why*, so teammates (and future you) understand the history at a glance.

### Step 5 — Push
Send your commits up to GitHub so your team can see them:
```
git push
```

### Step 6 — Pull again before you push, if it's been a while
If you took a break or others may have pushed in the meantime, `git pull` first — Git will tell you if it can't push because you're behind.

---

## 5. Quick Reference Cheat Sheet

| Command | What it does |
|---|---|
| `git clone <url>` | Download a copy of the repo (once per computer) |
| `git pull` | Get the latest changes from GitHub |
| `git status` | See what's changed, staged, or untracked |
| `git add <file>` | Stage a specific file |
| `git add .` | Stage all changed files |
| `git commit -m "message"` | Save a snapshot of staged changes |
| `git push` | Upload your commits to GitHub |
| `git log` | View commit history |
| `git diff` | See exact line-by-line changes before staging |

---

## 6. Working with Branches (recommended for group work)

Branches let you work on a feature without disturbing the main codebase until it's ready.

```
git checkout -b my-feature-name     # create and switch to a new branch
git push -u origin my-feature-name  # push it to GitHub the first time
```

When your feature is done, open a **Pull Request** on GitHub so the team can review it before merging into `main`. To switch back to the main branch:
```
git checkout main
git pull
```

---

## 7. If You Hit a Merge Conflict

A conflict happens when two people edit the same lines of the same file. Git will pause and mark the conflicting section in the file like this:

```
<<<<<<< HEAD
your version of the line
=======
their version of the line
>>>>>>> branch-name
```

To resolve it:
1. Open the file and decide which version (or combination) to keep.
2. Delete the `<<<<<<<`, `=======`, and `>>>>>>>` markers.
3. Save the file, then:
   ```
   git add filename
   git commit
   ```

Don't panic — conflicts are normal in group projects, not a sign something went wrong.

---

## 8. Good Habits for This Repo

- **Pull often**, especially before starting new work and before pushing.
- **Commit small and often** — one logical change per commit, rather than one giant commit at the end of the day.
- **Write clear commit messages** — "fix bug" tells nobody anything; "fix broken image path on About page" does.
- **Don't commit directly to `main`** if your team is using branches + Pull Requests — check with your teammates on the workflow you've agreed on.
- If you're ever unsure what a command will do, `git status` is always safe to run and will tell you where you stand.

---

## 9. Getting Help

- `git help <command>` — e.g. `git help commit`
- [git-scm.com/docs](https://git-scm.com/docs) — official documentation
- Ask a teammate before force-pushing or running anything with `--force` — it can overwrite others' work.
