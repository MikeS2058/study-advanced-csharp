# GitHub Repository Creation Script
# Run this script to create and push to GitHub

# Color output functions
function Write-Success { param($msg) Write-Host "✅ $msg" -ForegroundColor Green }
function Write-Info { param($msg) Write-Host "ℹ️  $msg" -ForegroundColor Cyan }
function Write-Warning { param($msg) Write-Host "⚠️  $msg" -ForegroundColor Yellow }
function Write-Error { param($msg) Write-Host "❌ $msg" -ForegroundColor Red }

Write-Info "GitHub Repository Setup Script"
Write-Info "Repository: Learning_AdvancedCSharpStudies"
Write-Host ""

# Check current directory
$currentDir = Get-Location
if ($currentDir.Path -notlike "*Learning_AdvancedCSharpStudies") {
    Write-Error "Please run this script from the Learning_AdvancedCSharpStudies directory"
    exit 1
}

Write-Success "Current directory: $currentDir"

# Check if git repository exists
if (-not (Test-Path ".git")) {
    Write-Error "Not a git repository. Please initialize git first."
    exit 1
}

Write-Success "Git repository found"

# Check git status
Write-Info "Checking git status..."
$status = git status --porcelain
if ($status) {
    Write-Warning "Uncommitted changes detected. Committing all changes..."
    git add -A
    git commit -m "Repository setup complete - ready for GitHub"
    Write-Success "Changes committed"
} else {
    Write-Success "Working tree is clean"
}

# Check current branch
$branch = git branch --show-current
Write-Info "Current branch: $branch"

# Check for existing remote
$remote = git remote -v
if ($remote) {
    Write-Warning "Remote already exists:"
    Write-Host $remote
    $continue = Read-Host "Do you want to continue? (y/n)"
    if ($continue -ne 'y') {
        Write-Info "Aborted by user"
        exit 0
    }
} else {
    Write-Info "No remote configured yet"
}

Write-Host ""
Write-Info "=========================================="
Write-Info "GitHub Repository Creation Options"
Write-Info "=========================================="
Write-Host ""
Write-Host "1. Use GitHub CLI (gh) - Recommended"
Write-Host "2. Manual setup with instructions"
Write-Host "3. Exit"
Write-Host ""

$choice = Read-Host "Select an option (1-3)"

switch ($choice) {
    "1" {
        Write-Info "Attempting to use GitHub CLI..."

        # Check if gh is installed
        try {
            $ghVersion = gh --version 2>$null
            if ($ghVersion) {
                Write-Success "GitHub CLI is installed"
                Write-Info "Version: $($ghVersion[0])"
            }
        } catch {
            Write-Error "GitHub CLI (gh) is not installed or not in PATH"
            Write-Info "Install from: https://cli.github.com/"
            exit 1
        }

        # Check authentication
        Write-Info "Checking GitHub authentication..."
        try {
            $authStatus = gh auth status 2>&1
            Write-Success "Authenticated to GitHub"
        } catch {
            Write-Warning "Not authenticated to GitHub"
            Write-Info "Running authentication..."
            gh auth login
        }

        # Get repository details
        Write-Host ""
        $repoName = Read-Host "Repository name [Learning_AdvancedCSharpStudies]"
        if ([string]::IsNullOrWhiteSpace($repoName)) {
            $repoName = "Learning_AdvancedCSharpStudies"
        }

        $description = Read-Host "Description [Advanced C# language features and patterns study project]"
        if ([string]::IsNullOrWhiteSpace($description)) {
            $description = "Advanced C# language features and patterns study project"
        }

        $visibility = Read-Host "Visibility: public or private [public]"
        if ([string]::IsNullOrWhiteSpace($visibility)) {
            $visibility = "public"
        }

        # Create repository
        Write-Info "Creating GitHub repository: $repoName"
        Write-Info "Description: $description"
        Write-Info "Visibility: $visibility"
        Write-Host ""

        try {
            gh repo create $repoName --$visibility --source=. --remote=origin --description $description
            Write-Success "Repository created on GitHub!"

            # Push to GitHub
            Write-Info "Pushing to GitHub..."
            git push -u origin $branch
            Write-Success "Code pushed to GitHub!"

            # Get repository URL
            $repoUrl = gh repo view --json url -q .url
            Write-Success "Repository URL: $repoUrl"

            # Open in browser
            $openBrowser = Read-Host "Open repository in browser? (y/n) [y]"
            if ([string]::IsNullOrWhiteSpace($openBrowser) -or $openBrowser -eq 'y') {
                gh repo view --web
            }

        } catch {
            Write-Error "Failed to create repository: $_"
            exit 1
        }
    }

    "2" {
        Write-Info "Manual Setup Instructions"
        Write-Host ""
        Write-Info "Step 1: Create repository on GitHub.com"
        Write-Host "  1. Go to https://github.com/new"
        Write-Host "  2. Repository name: Learning_AdvancedCSharpStudies"
        Write-Host "  3. Description: Advanced C# language features and patterns study project"
        Write-Host "  4. Choose Public or Private"
        Write-Host "  5. DO NOT initialize with README, .gitignore, or license"
        Write-Host "  6. Click 'Create repository'"
        Write-Host ""

        $created = Read-Host "Have you created the repository on GitHub? (y/n)"

        if ($created -eq 'y') {
            Write-Host ""
            Write-Info "Step 2: Enter your GitHub username"
            $username = Read-Host "GitHub username"

            Write-Host ""
            Write-Info "Step 3: Choose connection method"
            Write-Host "  1. HTTPS (recommended for beginners)"
            Write-Host "  2. SSH (requires SSH key setup)"
            $method = Read-Host "Select method (1-2)"

            if ($method -eq "1") {
                $remoteUrl = "https://github.com/$username/Learning_AdvancedCSharpStudies.git"
            } else {
                $remoteUrl = "git@github.com:$username/Learning_AdvancedCSharpStudies.git"
            }

            Write-Info "Adding remote: $remoteUrl"
            git remote add origin $remoteUrl

            Write-Info "Pushing to GitHub..."
            git push -u origin $branch

            Write-Success "Done! Your repository should now be on GitHub."
            Write-Info "Visit: https://github.com/$username/Learning_AdvancedCSharpStudies"
        } else {
            Write-Info "Please create the repository on GitHub first, then run this script again."
        }
    }

    "3" {
        Write-Info "Exited by user"
        exit 0
    }

    default {
        Write-Error "Invalid option"
        exit 1
    }
}

Write-Host ""
Write-Success "=========================================="
Write-Success "GitHub Repository Setup Complete!"
Write-Success "=========================================="
Write-Host ""

# Show final git remote status
Write-Info "Current remotes:"
git remote -v

Write-Host ""
Write-Info "Next steps:"
Write-Host "  - Add repository topics on GitHub"
Write-Host "  - Configure branch protection rules"
Write-Host "  - Set up GitHub Actions (optional)"
Write-Host "  - Enable GitHub Pages for documentation (optional)"
Write-Host ""