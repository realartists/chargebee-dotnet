namespace ChargeBee.Models {
  using System;
  using System.ComponentModel;
  using System.Net.Http;
  using ChargeBee.Api;
  using ChargeBee.Filters.Enums;
  using ChargeBee.Internal;
  using ChargeBee.Models.Enums;

  public class Comment : Resource {
    public static CreateRequest Create() {
      string url = ApiUtil.BuildUrl("comments");
      return new CreateRequest(url, HttpMethod.Post);
    }
    public static EntityRequest<Type> Retrieve(string id) {
      string url = ApiUtil.BuildUrl("comments", CheckNull(id));
      return new EntityRequest<Type>(url, HttpMethod.Get);
    }
    public static CommentListRequest List() {
      string url = ApiUtil.BuildUrl("comments");
      return new CommentListRequest(url);
    }
    public static EntityRequest<Type> Delete(string id) {
      string url = ApiUtil.BuildUrl("comments", CheckNull(id), "delete");
      return new EntityRequest<Type>(url, HttpMethod.Post);
    }

    public string Id {
      get { return GetValue<string>("id", true); }
    }
    public EntityTypeEnum EntityType {
      get { return GetEnum<EntityTypeEnum>("entity_type", true); }
    }
    public string AddedBy {
      get { return GetValue<string>("added_by", false); }
    }
    public string Notes {
      get { return GetValue<string>("notes", true); }
    }
    public DateTime CreatedAt {
      get { return (DateTime)GetDateTime("created_at", true); }
    }
    public TypeEnum CommentType {
      get { return GetEnum<TypeEnum>("type", true); }
    }
    public string EntityId {
      get { return GetValue<string>("entity_id", true); }
    }

    public class CreateRequest : EntityRequest<CreateRequest> {
      public CreateRequest(string url, HttpMethod method)
              : base(url, method) {
      }

      public CreateRequest EntityType(EntityTypeEnum entityType) {
        _params.Add("entity_type", entityType);
        return this;
      }
      public CreateRequest EntityId(string entityId) {
        _params.Add("entity_id", entityId);
        return this;
      }
      public CreateRequest Notes(string notes) {
        _params.Add("notes", notes);
        return this;
      }
      public CreateRequest AddedBy(string addedBy) {
        _params.AddOpt("added_by", addedBy);
        return this;
      }
    }

    public class CommentListRequest : ListRequestBase<CommentListRequest> {
      public CommentListRequest(string url)
              : base(url) {
      }

      public CommentListRequest EntityType(EntityTypeEnum entityType) {
        _params.AddOpt("entity_type", entityType);
        return this;
      }
      public CommentListRequest EntityId(string entityId) {
        _params.AddOpt("entity_id", entityId);
        return this;
      }
      public TimestampFilter<CommentListRequest> CreatedAt() {
        return new TimestampFilter<CommentListRequest>("created_at", this);
      }
      public CommentListRequest SortByCreatedAt(SortOrderEnum order) {
        _params.AddOpt("sort_by[" + order.ToString().ToLower() + "]", "created_at");
        return this;
      }
    }

    public enum TypeEnum {
      Unknown,
      [Description("user")]
      User,
      [Description("system")]
      System,
    }
  }
}
