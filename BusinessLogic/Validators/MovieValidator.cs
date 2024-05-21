using BusinessLogic.DTOs;
using FluentValidation;

namespace BusinessLogic.Validators
{
    public class MovieValidator : AbstractValidator<MovieDto>
    {
        public MovieValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().MinimumLength(1);
            RuleFor(x => x.GenreId).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Image).NotEmpty().Must(LinkMustBeAUri).WithMessage("{PropertyName} must be a valid URL address.");
            RuleFor(x => x.Trailer).NotEmpty().Must(LinkMustBeAUri).WithMessage("{PropertyName} must be a valid URL address.");
            RuleFor(x => x.Video).NotEmpty().Must(LinkMustBeAUri).WithMessage("{PropertyName} must be a valid URL address.");
            RuleFor(x => x.Year).NotEmpty().GreaterThanOrEqualTo(1895);
            RuleFor(x => x.Limit).NotEmpty().GreaterThanOrEqualTo(0);
            RuleFor(x => x.Rating).NotEmpty().GreaterThanOrEqualTo(0).LessThanOrEqualTo(10);
        }

        private static bool LinkMustBeAUri(string link)
        {
            if (string.IsNullOrWhiteSpace(link))
            {
                return false;
            }

            //Courtesy of @Pure.Krome's comment and https://stackoverflow.com/a/25654227/563532
            Uri outUri;
            return Uri.TryCreate(link, UriKind.Absolute, out outUri)
                   && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps);
        }
    }
}
