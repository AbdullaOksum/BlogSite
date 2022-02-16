using BlogSite.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogSite.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.AuthorName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.AuthorEmail).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500).IsRequired();

            builder.HasMany(x => x.SubComment).WithOne(x => x.ParrentComment).HasForeignKey(x => x.ParetCommentId);

        }
    }
}
